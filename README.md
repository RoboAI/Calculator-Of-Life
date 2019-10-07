# Calculator-Of-Life
The best calculator

## Welcome to the worlds best calculator..

Have a look at the SimpleVersion project in the solution to see a simpified version of how everything is put together..

Then, to add functionality to CalculatorOfLife:

1) Create a class and inherit from CalculatorBase

```cs
class AwesomeNewFunction : CalculatorBase{
  
}
```

2) Add two methods to the above class; DoIt() and GetDescription(), and **override** them:

```cs
public override void DoIt(){
  //do funky stuff
}

public override void GetDescription(){
  //return what this functionality is. This string is added to the Menu
  return "A surprise function";
}
```

3) Add your new class to the 'list' in CalculatorOfLife.Initialise()...

```cs
list.Add(new AwesomeNewFunction());
```
