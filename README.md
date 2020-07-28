# Dragonfly.Umbraco8PeekabooProperties #

An Umbraco v8 package created by [Heather Floyd](https://www.HeatherFloyd.com).

Based on the v7 package [uDynamic](https://our.umbraco.com/packages/backoffice-extensions/udynamic).

## Installation ##

Install via NuGet

## Setup ##

Create a new Datatype using either the 'Peekaboo Checkbox List' or 'Peekaboo Dropdown List' property editor.

Configure By adding various Prevalue options: 

1. The first column "Display Text" is the value as it will appear to the Content Editor in the list. 
1. The second column "Key" is a value to represent that option in code - it should have no spaces or special characters.
1. The third column "Affects Groups" is where you type in codes, using the **group name** (with spaces, if needed), to represent which groups are affected when that prevalue is selected.
1. The fourth column "Affects Properties" is where you type in codes, using the **property alias**, to represent which properties are affected when that prevalue is selected.


For each prevalue option you can specifically Show or Hide other Properties and/or Tabs.

Use this simple code to show or hide items:
- Use a '+' to Show something when that prevalue is selected. 
- Use a '-' to Hide something when the prevalue is selected. 

Specify multiple groups or properties using commas.

*Examples:*

    +Group A,+Group B,-Group C 

    +PropertyA,-PropertyB

## Tips ##

- Be careful hiding Mandatory properties that will prevent the Content from being Saved.
- To keep things together and reusable, put all the related Properties/Groups onto a single "Composition" Doctype with the Peekaboo Property at the top.

## Known Issues ##
- The showing/hiding doesn't work inside a Nested Content property
- The Jquery Plugin rendering hasn't been tested.
- The Checkbox List datatype hasn't been as thoroughly tested as the Dropdown.

