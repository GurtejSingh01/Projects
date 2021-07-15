//Task Data
const TaskData = [
                    {date: "20-01-2020", name: "Task 01", desc: "Create blue print", completed: "Yes"},
                    {date: "21-01-2020", name: "Task 02", desc: "Create UML Diagram", completed: "Yes"},
                    {date: "24-01-2020", name: "Task 03", desc: "Create Flow-Chart Diagram", completed: "Yes"},
                    {date: "24-01-2020", name: "Task 04", desc: "Designing", completed: "No"},
                    {date: "02-02-2020", name: "Task 05", desc: "Coding", completed: "Yes"},
                    {date: "10-02-2020", name: "Task 06", desc: "Implementation of Diagram", completed: "No"},
                    {date: "14-02-2020", name: "Task 07", desc: "Implementation of Flow-Chart Diagram", completed: "No"},
                 ];

//factory function to add task details in TaskData
function task(date, name, desc){
    return {date, name, desc};
}

//function to add task in TaskData
function addTask() {
    var createdDate = document.getElementById("date").value;
    var taskName = document.getElementById("taskName").value;
    var taskDesc = document.getElementById("taskDesc").value;
    //alert(createdDate+" "+taskName+" "+taskDesc);
    let t = task(createdDate, taskName, taskDesc);
    console.log(t);
    TaskData.concat(t);
    console.log(TaskData);
    alert("Task created!");
}

//Adding TaskData Details in form to be displayed in combo box
function displayTaskDetails() {
    var tasksName = TaskData.map(d => "<option>"+d.name+": created on - "+d.date+"</option>");
    //alert("Task Displayed"+tasksName);
    return tasksName;
    //console.log(tasksName);
}

//fetching particular task details
function getTaskDetails(taskName){
    //alert(taskName);
    var t = TaskData.find(d => taskName.includes(d.name));
    return t;
}

//Adding TaskData Details in the home page
function displayDataInHomePage() {
    var i;
    var tasksName = "<tr><th> Tasks Number and Task creation Date</th><th>Status</th></tr>";
    var temp = TaskData.map(d => "<tr><td>"+d.name+" : created on - "+d.date+"</td><td align='center'>Completed: "+d.completed+"</td></tr>");
    for(i = 0; i<temp.length; i++)
    {
        tasksName += temp[i];
    }
    var yesFilter = TaskData.filter(d => (d.completed === "Yes"));
    var noFilter = TaskData.filter(d => (d.completed === "No"));
    tasksName += "<tr><td>Total Tasks Completed: "+yesFilter.length+"</td><td>Tasks Remaining to Complete: "+noFilter.length+"</td></tr>";
    return tasksName;
}