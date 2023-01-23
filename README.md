We would like you to produce a pizza factory application that generates a fixed number of pizzas using a range of 3 different pizza bases with 3 different toppings. 
Each pizza base and topping has different cooking times.  The pizza bases must use a base cooking time in milliseconds taken from a configuration file.  Each pizza base will then adjust that cooking time based on its type, details in the table below.
Pizza Base	Cooking time multiplier
Deep Pan	2x
Stuffed Crust	1.5x
Thin and Crispy	1x

The cooking time of the topping will be 100ms for each letter contained in the name of the topping.  The toppings are “Ham and Mushroom”, “Pepperoni” and “Vegetable”.
Therefore, given a Deep Pan Pepperoni pizza is ordered and the base cooking time is 3000ms then the total cooking time will be 6900ms.
Once a pizza is cooked, it is not valid for it to be cooked again and it should not be possible to cook a pizza without any toppings.
When the pizza factory is started it must produce 50 pizzas, though this value should also be configurable.  Initially the pizzas should be cooked on a fixed interval basis though this may need to change in the future.  The interval at which pizzas are cooked should be a millisecond value held in the configuration file.
The pizza that gets cooked each time should be a random base with a random topping.
When a pizza is being cooked, the application should simulate this by sleeping for the cooking time that has been calculated.
Once a pizza has finished cooking, a description comprising the pizza base type and the name of the topping should be written to a file, the full name of which should be configurable. If creating an Angular application, this could be displayed in the UI instead.
When the pizza factory has finished generating pizzas, the application should terminate.
The completed application should build and run on a Windows machine.  Any libraries or packages required to build and run the application should be included with the solution.  The solution is to be completed either as a console application in C# or Java, or as an Angular application.
