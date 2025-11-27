const num1 = document.getElementById("num1");
const num2 = document.getElementById("num2");
const result = document.getElementById("result");
const buttonsDiv = document.getElementById("buttons");

// ========== LOCAL STORAGE-DƏN DATALARI YÜKLƏ ==========
window.onload = () => {
    if (localStorage.getItem("num1")) num1.value = localStorage.getItem("num1");
    if (localStorage.getItem("num2")) num2.value = localStorage.getItem("num2");
    if (localStorage.getItem("result")) result.value = localStorage.getItem("result");
};

// INPUT DƏYİŞƏNDƏ LOCALSTORAGE-Ə YAZ
[num1, num2].forEach(inp => {
    inp.addEventListener("input", () => {
        localStorage.setItem(inp.id, inp.value);
    });
});


// =================== STYLES ===================
document.body.style.display = "flex";
document.body.style.flexDirection = "column";
document.body.style.alignItems = "center";
document.body.style.gap = "20px";
document.body.style.paddingTop = "50px";
document.body.style.background = "#659fa3";
document.body.style.height = "100vh";

[num1, num2, result].forEach(inp => {
    inp.style.width = "300px";
    inp.style.height = "40px";
    inp.style.borderRadius = "10px";
    inp.style.border = "none";
    inp.style.fontSize = "20px";
    inp.style.padding = "10px";
});

result.style.background = "#fff8";
result.style.fontWeight = "bold";

buttonsDiv.style.display = "flex";
buttonsDiv.style.gap = "20px";


// =================== CALCULATOR FUNCTION ===================
function calc(type) {
    const a = parseFloat(num1.value);
    const b = parseFloat(num2.value);

    if (isNaN(a) || isNaN(b)) {
        result.value = "Enter numbers!";
        localStorage.setItem("result", result.value);
        return;
    }

    let res;
    switch (type) {
        case "plus":  res = a + b; break;
        case "minus": res = a - b; break;
        case "mult":  res = a * b; break;
        case "div":
            if (b === 0) {
                result.value = "Cannot divide by 0";
                localStorage.setItem("result", result.value);
                return;
            }
            res = a / b;
            break;
    }

    result.value = res;
    localStorage.setItem("result", res);
}


// =================== BUTTONS ===================
const btnData = [
    { text: "Plus", type: "plus" },
    { text: "Minus", type: "minus" },
    { text: "Mult", type: "mult" },
    { text: "Divide", type: "div" }
];

btnData.forEach(b => {
    const btn = document.createElement("button");
    btn.innerText = b.text;
    btn.style.padding = "10px 20px";
    btn.style.fontSize = "18px";
    btn.style.borderRadius = "8px";
    btn.style.border = "1px solid black";
    btn.style.cursor = "pointer";

    btn.onclick = () => calc(b.type);

    buttonsDiv.appendChild(btn);
});
