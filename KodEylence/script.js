const images = [
  "download.png",
  "istockphoto-1160791767-612x612.jpg",
  "istockphoto-147694372-612x612.jpg",
  "Susqun.png",
  "Bomj_Volodia.jpg",
  "ab67616d00001e024198c92ec28483da79c7894d.png",
  "images.png",
  "void.png",
  "tired-baby-807688390.avif"
];

const titles = [
  "Isyankar",
  "Zarafatcil",
  "Aqressiv",
  "Susqun",
  "Bomj",
  "Chat",
  "Sair",
  "404NotFound",
  "Yuxulu"
];

const container = document.getElementById("cardsContainer");

images.forEach((img, index) => {

  const card = document.createElement("div");
  card.className = "card";
  card.textContent = titles[index];

  const imageBox = document.createElement("div");
  imageBox.className = "imageBox";

  card.appendChild(imageBox);

  card.onclick = () => {

    card.classList.toggle("selected");

    if (card.classList.contains("selected")) {
      imageBox.innerHTML = `<img src="${img}">`;
    } else {
      imageBox.innerHTML = "";
    }
  };

  container.appendChild(card);
});
