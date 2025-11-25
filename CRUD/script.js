document.body.style.margin = "0";
document.body.style.padding = "0";
document.body.style.background = "#A4C9BD";
document.body.style.fontFamily = "Arial, sans-serif";

const main = document.createElement("div");
main.style.width = "100%";
main.style.height = "100vh";
main.style.display = "flex";
main.style.alignItems = "center";
main.style.justifyContent = "center";
main.style.padding = "20px";
document.body.appendChild(main);

const content = document.createElement("div");
content.style.width = "95%";
content.style.height = "80%";
content.style.display = "flex";
content.style.justifyContent = "space-between";
content.style.alignItems = "center";
main.appendChild(content);

const leftBlock = document.createElement("div");
leftBlock.style.width = "50%";
leftBlock.style.height = "100%";
leftBlock.style.display = "flex";
leftBlock.style.alignItems = "center";
leftBlock.style.justifyContent = "center";
content.appendChild(leftBlock);

const img = document.createElement("img");
img.src = "images.png";
img.style.width = "80%";
img.style.borderRadius = "15px";
img.style.boxShadow = "0 4px 20px rgba(0,0,0,0.15)";
leftBlock.appendChild(img);

const rightBlock = document.createElement("div");
rightBlock.style.width = "45%";
rightBlock.style.height = "100%";
rightBlock.style.display = "flex";
rightBlock.style.flexDirection = "column";
rightBlock.style.alignItems = "center";
rightBlock.style.justifyContent = "center";
content.appendChild(rightBlock);

const title = document.createElement("h1");
title.innerText = "Registration";
title.style.color = "#2C4D46";
title.style.marginBottom = "40px";
rightBlock.appendChild(title);

function createRow() {
    const row = document.createElement("div");
    row.style.width = "100%";
    row.style.display = "flex";
    row.style.justifyContent = "center";
    row.style.gap = "25px";
    row.style.marginBottom = "20px";
    return row;
}

function createInput(ph) {
    const inp = document.createElement("input");
    inp.placeholder = ph;
    inp.style.width = "190px";
    inp.style.padding = "12px 15px";
    inp.style.borderRadius = "20px";
    inp.style.border = "none";
    inp.style.fontSize = "14px";
    return inp;
}

const row1 = createRow();
row1.appendChild(createInput("First name"));
row1.appendChild(createInput("Last name"));
rightBlock.appendChild(row1);

const row2 = createRow();
row2.appendChild(createInput("First name"));
row2.appendChild(createInput("Last name"));
rightBlock.appendChild(row2);

const btn = document.createElement("button");
btn.innerText = "Register";
btn.style.marginTop = "10px";
btn.style.padding = "10px 35px";
btn.style.border = "none";
btn.style.borderRadius = "20px";
btn.style.background = "#3F5D4E";
btn.style.color = "white";
btn.style.fontSize = "15px";
btn.style.cursor = "pointer";
btn.style.boxShadow = "0 3px 8px rgba(0,0,0,0.3)";
rightBlock.appendChild(btn);

btn.addEventListener("click", () => {
    alert("Registration Successful!");
});