document.addEventListener("DOMContentLoaded", function() {
    const popup = document.getElementById("popup");
    const popupName = document.getElementById("popup-name");
    const popupInfo = document.getElementById("popup-info");
    const closeBtn = document.querySelector(".close-btn");
    const audio = document.getElementById("audio");

    const pessoas = [
        {
            nome: "Pedro Henrique Morereira",
            info: "Programador",
            musica: "musicas/tony-country.mp3" 
        },
        {
            nome: "Wecton Santos",
            info: "Programador",
            musica: "musicas/wecton.mp3" 
        }
    ];

    document.querySelectorAll('.imgPedro, .imgWecton').forEach((img, index) => {
        img.addEventListener('click', () => {
            popupName.textContent = pessoas[index].nome;
            popupInfo.textContent = pessoas[index].info;
            popup.style.display = "block";

            audio.src = pessoas[index].musica;
            audio.currentTime = 0; 
            audio.play(); 
        });
    });

    closeBtn.addEventListener("click", function() {
        popup.style.display = "none";
        audio.pause(); 
    });

    window.addEventListener("click", function(event) {
        if (event.target == popup) {
            popup.style.display = "none";
            audio.pause(); 
        }
    });
});

window.addEventListener('scroll', () => {
    const elements = document.querySelectorAll('.sobre, .apresentacao, .quemSomos');
    elements.forEach(element => {
        if (element.getBoundingClientRect().top < window.innerHeight) {
            element.classList.add('visible');
        }
    });
});

window.onload = () => {
    document.getElementById('loading').style.display = 'none';
};
