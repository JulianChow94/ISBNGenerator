
The exercise was completed in roughly 54 minutes (this README was written after the fact)
This README is essentially a self-reflection on how I managed the
hour of time I was given to complete the task.


Understanding the Task:
    Understanding the problem went quite smoothly,
    giving the document a quick 5-minute run through;
    I was able to figure out roughly how I would approach the problem and how my algorithm would look like

Tackling the Problem:
    This did not go well, I spent like the next 15-20 minutes setting up "boiler plate code".
    By this I mean setting up how I would handle user input, sanitizing checks on the string input,
    and how I would handle the error when user input is of the wrong format.
    I was also unfamiliar with a lot of the `Console` methods so that attributed to how long it took me
    to set up the boiler plate code.

    As a result, I spent a significant amount of time (almost half of the hour) dabbling around in `Program.cs`
    trying to "set up" the program instead of figuring out and building the actual algorithm.
    I decided to stop at a point where the Program works, but should appear to be very rough around the edges.
    I did not think I would have enough time to make any significant improvements with the time I had left.

    Giving my solution another pass, this becomes very obvious:
    - The part of the code which handles user input has significant error checks built around it and
        entering a input with a wrong format is handled in almost every case I can imagine
    - IsbnBuilder _works_ but is largely brittle in the sense that I had no time to handle any error cases
        and the class simply assumes all objects passed into it will have the right format. Potential for
        unhandled exceptions being thrown in IsbnBuilder would be high.
    - After getting it to work for a basic input/output, I felt like I only had enough time to apply
        some unit testing to the basic test cases outlined in the document on IsbnBuilder only.
        Had I managed my time more efficiently / had more time, I should have been able to refactor
        the program such that every small component could be effectively unit tested.


