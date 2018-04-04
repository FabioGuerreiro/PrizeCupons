# Problem / Requirements

To support a sales promotion of a massively sold consumer product, there is a prize contest where customers will go online and submit a coupon consisting of any combination of 6 characters alphanumeric from range [A..F](English capital letters) and [0..9](numbers) p.e. AA01FD, 08DF37,4B2000.

Navigating to the advertised URL, the user will be prompted to submit the 6-character code, and instantly will be notified, on whether this is a winning code or not. In case we have a winner, the user will be prompted to fill their details to receive their prize. The details required are: a) full name, b) full address c) telephone number. There is no restriction on how many prizes one person can win.

We expect millions of users worldwide to take part on this, and access the web site (thousands of concurrent users). The winning code together with the winner details must be stored in order the marketing department to pick them up and process the delivery of the prize. Whether a code wins or not is decided upon the following condition. Dividing the code as a hexadecimal number with 65353, if the result is a prime number, this is a winning code. The marketing department must be able to change the possible number of winners (for next campaigns) without rebuilding the web solution or change the code.

# Solution

Create a web solution that solves the above problem. The solution must compile and be readable in MS visual studio although any environment can be used. Creativity is encouraged. Any library, technology, or resource can be used for the benefit of saving time, increasing quality, creating attractive presentation, but the solution must be based on at least one element of ASP.NET (p.e MVC, API etc) and a modern JS technology (AngularJS, ReactJS etc). The solution must be configurable, easily deployable, so instructions must be included if necessary. The solution should demonstrate that quality mechanisms were used to ensure correctness. There are no correct and wrong solutions to the problem.
