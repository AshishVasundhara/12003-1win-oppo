﻿/**
 * Flat Calendar
 * 
 * This is an example scene of Flat Calendar
 *
 * @version 1.0
 * @author  Gerardo Ritacco
 * @email   gerardo.ritacco@3dresearch.it
 * @company 3dresearchsrl
 * @website http://www.3dresearch.it/
 * 
 * Copyright © 2016 by 3dresearchsrl
 *
 * All rights reserved. No part of this publication may be reproduced, distributed, 
 * or transmitted in any form or by any means, including photocopying, recording, or 
 * other electronic or mechanical methods, without the prior written permission of the 
 * publisher, except in the case of brief quotations embodied in critical reviews and 
 * certain other noncommercial uses permitted by copyright law. For permission requests, 
 * write to the publisher, addressed “Attention: Permissions Coordinator,” at the address below.
 */

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using static FlatCalendar;

public class FlatCalendar_Demo : MonoBehaviour {

	// Declare FlatCalendar
	FlatCalendar flatCalendar;

	// Use this for initialization
	void Start () {

		// Get Flat Calendar Instance
		flatCalendar = GameObject.Find("FlatCalendar").GetComponent<FlatCalendar>();

		// Initialize Flat Calendar
		flatCalendar.initFlatCalendar();

		// Install Demo Event List
		flatCalendar.installDemoData();

		// Add Events Callbacks
		flatCalendar.setCallback_OnDaySelected(dayUpdated);
		flatCalendar.setCallback_OnMonthChanged(monthUpdated);
		flatCalendar.setCallback_OnEventSelected(eventsDiscovered);
		flatCalendar.setCallback_OnNowday(backHome);

		// Set UI Style
		flatCalendar.setUIStyle(1);

        // Add Event Demo
        EventObj demoEvent = new EventObj("Event Name", "Event Description");
        flatCalendar.addEvent(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, demoEvent);

	}

	
	// Update is called once per frame
	void Update () {
		

	}

	public void dayUpdated(FlatCalendar.TimeObj time)
	{
		Debug.Log("Day has changed");
		time.print();
	}

	public void monthUpdated(FlatCalendar.TimeObj time)
	{
		Debug.Log("Month has changed");
		time.print();
	}

	public void eventsDiscovered(FlatCalendar.TimeObj time, List<FlatCalendar.EventObj> list)
	{
		Debug.Log("You have selected a day with: "+list.Count+ "events");
		for(int i = 0; i < list.Count; i++)
			Debug.Log("Event: " + i + " ==> " + "Name: " + list[i].name + " Description: " + list[i].description);
	}

	public void backHome(FlatCalendar.TimeObj time)
	{
		Debug.Log("You have come back at home");
		time.print();
	}
}
