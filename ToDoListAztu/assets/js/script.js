const input = document.getElementById("taskInput");
const addBtn = document.getElementById("addBtn");
const taskList = document.getElementById("taskList");

// ===================== LOCALSTORAGE =====================

// LocalStorage-dən task-ları götür
let tasks = JSON.parse(localStorage.getItem("tasks")) || [];

// Səhifə açılan kimi task-ları ekrana yaz
window.onload = () => {
  tasks.forEach(t => createTask(t));
};

// LocalStorage-a yazan funksya
function saveTasks() {
  localStorage.setItem("tasks", JSON.stringify(tasks));
}

// ========================================================


// ADD BUTTON
addBtn.addEventListener("click", () => {
  const text = input.value.trim();

  if (text === "") {
    alert("Please enter a task!");
    return;
  }

  tasks.push(text);
  saveTasks();

  createTask(text);
  input.value = "";
});


// ===================== TASK YARADAN FUNKSIYA =====================
function createTask(text) {
  const li = document.createElement("li");

  const span = document.createElement("span");
  span.innerText = text;

  const editBtn = document.createElement("button");
  editBtn.innerText = "Edit";

  const deleteBtn = document.createElement("button");
  deleteBtn.innerText = "Delete";


  // Edit düyməsi
  editBtn.addEventListener("click", () => {
    const newText = prompt("Edit task:", span.innerText);

    if (newText !== null && newText.trim() !== "") {
      // Köhnəni tasks massivində tapıb dəyişirik
      const index = tasks.indexOf(span.innerText);
      if (index !== -1) {
        tasks[index] = newText.trim();
        saveTasks();
      }
      span.innerText = newText;
    }
  });


  // Delete düyməsi
  deleteBtn.addEventListener("click", () => {
    // Massivdən silirik
    tasks = tasks.filter(t => t !== span.innerText);
    saveTasks();

    li.remove();
  });


  li.appendChild(span);
  li.appendChild(editBtn);
  li.appendChild(deleteBtn);
  taskList.appendChild(li);
}
