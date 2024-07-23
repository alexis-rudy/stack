# Stacks

### What are stacks and why are they important?
Imagine you're writing an essay for a class your taking. Now, this is an important essay - it's worth 30% of your grade. By accident, you delete an entire paragraph right in the middle. (Dang technology!) What do you do? 

This is where stacks come in. Most of us would use the undo button or shortcut (Ctrl + Z) to fix an unwanted mistake. Without stacks, this wouldn't be possible and your eloquently written paragraph would be gone forever. 

A stack is a data structure that records data through a first in last out method. Like a cone of ice cream flavors - you can put more flavor on the top, but to reach the first flavor you must eat your way down the cone until the end (you can't eat from the side in this case). 

For programming stacks are incredibly useful. There are two main functions to alter a stack: __push__ and __pop__. Push is adding an item to the back of the stack. For example let's say you had an ice cream cone with three flavors: vanilla, chocolate and mint, in that order. You want to include a strawberry flavor to your cone. To add a new flavor you must _push_ to the top or end of the cone. Your cone now looks like this: vanilla, chocolate, mint, strawberry. A few minutes later, you have finished two of your  flavors, _popping_ the strawberry, then _popping_ the mint. This leaves you with just vanilla and chocolate in the cone or stack. 

### Stacks in Programming

In programming, the biggest use of stacks is one we unconsciously use. In the background of any program written is a stack tracking what steps are being made. For instance, let's say you have program that assigns two variables. 

```csharp
int a = functionA(functionB);
int b = a + 5; 
Console.WriteLine(b);
```

In this example, there is a sequence of events that must occur in an order for it to run correctly. In order to assign the variable **_a_**, **_functionA_** must run. In order for **_functionA_** to run, **_functionB_** must complete. Going through the code, the stack would _push_ variable **_a_**'s assignment, then _push_ running **_functionA_**, then _push_ running **_functionB_**. The stack would look as follows: 

| Operation                              | Stack State       | Description                           |
|----------------------------------------|-------------------|---------------------------------------|
| Initial State                          |                   |                                       |
| `functionB`                            | `resultB`         | `functionB` is called, result pushed  |
| `functionA(resultB)`                   | `resultA`         | `functionA` is called with `resultB`, result pushed |
| `int a = resultA`                      | `resultA`         | `resultA` assigned to `a`             |
| `int b = a + 5`                        | `resultA, resultB`| `b` is calculated and pushed          |
| `Console.WriteLine(b)`                 | `resultA, resultB`| `b` is printed                        |

You can also get the size of a stack using the _size()_ function or check whether a stack is empty with _isEmpty()_.

### Example problems
Let's try an example. 

_Your boss asks you to write a function that reverses a given input. The function will take any data, and return a reversed string._

Try the problem on your own first, then look at my solution if needed.

[Stack Solution](stack_example)