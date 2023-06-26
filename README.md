<h1>Welcome to Jerello!</h1>
<h4>
    Jerello is a Jira/Trello like Task management application::POC implementation. 
</h4>

<p>
    Story Points: 1
</p>
<p>
    Tech Stack: .NET/C#, Blazor/MSBuild (Build), NUnit (tests), Azure APIs (for APIs), Razor (UI Components), Bootstrap (Styling & CSS)
</p>

<h3>Completed Tasks:</h3>

<ul>
    <li>Users can add new tasks to the task board.</li>
    <li>Details include name, description, summary, deadline.</li>
    <li>Users can see into tasks details.</li>
    <li>Users can edit the boolean work states (ToDo, Completed).</li>
    <li>Extensively Unit Tested code using NUnit (In Arrange, Act, Assert paradigm). This level of testing was not necessary for the scope, but is good long-term.</li>
    <li>Summary of the tasks (automatically updated) - # of task todo and # of task completed.</li>
    <li>Proper (Responsive, e.g. Navigation, Mobile devices) UI of home (/), /tasks, and /about routes (includes typography and icons).</li> 
    <li>Router Error handling: 404 pages are customized to current design system.</li>
    <li>JSON Serialization and Deserialization done from locally hosted data (/Data/fetchdata.json). Shhh, see the <a href="fetchdata">route</a>.</li>
    <li>Customizable API endpoint (/apis/fetchdata) that will expose JSON data (on status 200, see Controllers/FetchDataController.cs). Currently suppressed by router error handler.</li>
    <li>Wrote JavaScript code for column sorting, can be easily integrated to /tasks table (see Pages/_Host.cshtml).</li>
    <li>Standard Practices: Unit Testing, Modularizated Codebase (Namespaces), Strong Typing, Tight Integration to Application/Business logic (Razor UI Components), Separation of concerns (directory tree).
</ul>

Major Incomplete Tasks:

<ul>
    <li>Azure APIs could not be integrated (data persistence). But, since API endpoints has been set, it can be integrated by Azure CLI</li>
    <li>Complex handling of a task: Image allocation, Sorting implementation on UI</li>
</ul>

Since it was supposed to be a initial POC implementation, most of the complex tasks (image upload, CosmosDB integration) could not be implemented in deadline for the story. For a 1 story pointer, I'm feeling pretty good about it.

How to execute the application?

<ul>
    <li>Install .NET 7 SDK from the official package manager. Linux: `sudo apt-get update && sudo apt-get install -y dotnet-sdk-7.0`</li>
    <li>Install NUnit framework (`dotnet add package NUnit`)</li>
    <li>Run the command `dotnet watch run` and open `http://localhost:5009/`</li>
    <li>Building the project: `dotnet build`.</li>
</ul>

Screenshots:

![1](https://github.com/9x9x9x/jerello/assets/87396719/e08bc39c-0d77-496a-9de6-6191bcdcbb38)
![2](https://github.com/9x9x9x/jerello/assets/87396719/afd61d6e-cc81-4d52-96ee-28c53163f4ea)
![3](https://github.com/9x9x9x/jerello/assets/87396719/5be4d928-ef93-48d8-aa75-57cc7a86c2d5)
![4](https://github.com/9x9x9x/jerello/assets/87396719/69e8bf34-6ce0-4ba0-8ee2-38ef3943818d)
![5](https://github.com/9x9x9x/jerello/assets/87396719/5f912ef3-fa20-4529-82e7-c1a8068479b8)
![6](https://github.com/9x9x9x/jerello/assets/87396719/83612314-7193-49de-901c-f71066c98396)
![7](https://github.com/9x9x9x/jerello/assets/87396719/12733b60-3efb-4e01-9565-05ea245b8f63)
![8](https://github.com/9x9x9x/jerello/assets/87396719/306c545f-4cd8-4a4e-a660-0ba0cec43738)
![9](https://github.com/9x9x9x/jerello/assets/87396719/6bb0c189-503c-4e57-bd0f-86d1ea0f3d2d)
![10](https://github.com/9x9x9x/jerello/assets/87396719/3de924fa-e00d-4f15-bb99-2f0e16e08cf9)
