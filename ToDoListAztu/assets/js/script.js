const input = document.getElementById("taskInput");
const addBtn = document.getElementById("addBtn");
const taskList = document.getElementById("taskList");



let tasks = JSON.parse(localStorage.getItem("tasks")) || [];

window.onload = () => {
  tasks.forEach(t => createTask(t));
};

function saveTasks() {
  localStorage.setItem("tasks", JSON.stringify(tasks));
}



addBtn.addEventListener("click", () => {
  const text = input.value.trim();

  if (text === "") {
    alert("Please enter a task!");
    return;
  }

  const taskObj = {
    id: Date.now(),              
    text: text,                  
    date: new Date().toLocaleString()
  };

  tasks.push(taskObj);
  saveTasks();

  createTask(taskObj);
  input.value = "";
});



function createTask(taskObj) {
  const li = document.createElement("li");

  const span = document.createElement("span");
  span.innerText = taskObj.text;

  const detailBtn = document.createElement("button");
  detailBtn.innerText = "Details";

  const editBtn = document.createElement("button");
  editBtn.innerText = "Edit";

  const deleteBtn = document.createElement("button");
  deleteBtn.innerText = "Delete";


  detailBtn.addEventListener("click", () => {
    alert(
      `ID: ${taskObj.id}\n` +
      `Task: ${taskObj.text}\n` +
      `Created At: ${taskObj.date}`
    );
  });


  editBtn.addEventListener("click", () => {
    const newText = prompt("Edit task:", span.innerText);

    if (newText !== null && newText.trim() !== "") {
      span.innerText = newText.trim();

      const index = tasks.findIndex(t => t.id === taskObj.id);
      tasks[index].text = newText.trim();

      saveTasks();
    }
  });


  deleteBtn.addEventListener("click", () => {
    tasks = tasks.filter(t => t.id !== taskObj.id);
    saveTasks();

    li.remove();
  });


  li.appendChild(span);
  li.appendChild(detailBtn);
  li.appendChild(editBtn);
  li.appendChild(deleteBtn);
  taskList.appendChild(li);
}
