# Star Notation
Star Notation is a method of using Gherkin without specifiying the keywords (Given, When, Then, And, But) and instead using a ```*``` to represent a list of steps with no specific pre-conditions and actions with expected results (assertions).  

For example, if you wich to veryfiy buttons are displayed but nothing else:
```Gherkin
Feature: AddTwoNumbers
	In order to learn Math
	As a regular human
	I want to add two numbers using Calculator

Scenario: Verifiy buttons are displayed
	* The add button is displayed
	* The equals button is displayed
	* Buttons 0 to 9 are dispalyed
```

To implement the step method, the keyword ```*``` must be replaced with the ```Star```.

For example:
```C#
[Star(@"The add button is displayed")]
public void The_add_button_is_displayed()
```

## Why you shouldn't use Star Notation
Given/When/Then/etc keywords add clarity as to what you are referring to. Given and optional Ands denote context (precondition), When and optional Ands denote action (important interactions with the system or scenario), Then and optional Ands denote post-conditions and assertions (to verify the scenario is going well). 

Using Star Notation should be considered a last resort.