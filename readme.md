# Browser Navigation Simulation

## Overview

This project simulates a simple browser navigation system using stacks. The program should support the following operations:
- Visiting a new page
- Going back to the previous page
- Going forward to the next page
- Show the user their browsing history

## Task One: Implement Back Navigation
Build a method that simulates pressing the 'back' button on a webpage. The method should use a stack to find the previous page, and display it to the user. 

## Task Two: Implement Forward Navigation
 Build a method that simulates pressing the 'forward' button on a webpage. After going back, the user should be able to go forward if they haven't visited a new page in between. _Hint: try using a second stack_

 ## Task Three: Implement New Page Visit
 Build a method that simulates visiting a new webpage. This action should clear the forward navigation stack and add the new page to the back navigation stack.

## Task Four: Show Browser History
Build a method that displays the user's 'browsing' history. Any pages removed from the stack (went back and chose a new page) should not be displayed and should no longer be in the stack.