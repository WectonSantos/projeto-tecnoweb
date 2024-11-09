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

// parte da pag de jogo
document.addEventListener('DOMContentLoaded', function () {
    let currentIndex = 0;
    const images = document.querySelectorAll('.carousel-image');
    const totalImages = images.length;

    // Função para alterar a imagem (manual ou automático)
    function moveScreenshot(step) {
        // Remover a classe 'active' da imagem atual
        images[currentIndex].classList.remove('active');
        
        // Calcular o próximo índice, garantindo que seja circular
        currentIndex = (currentIndex + step + totalImages) % totalImages;
        
        // Adicionar a classe 'active' à próxima imagem
        images[currentIndex].classList.add('active');
    }

    // Função de autoplay (avança automaticamente)
    function autoPlay() {
        moveScreenshot(1); // Avançar uma imagem
    }

    // Ativar o autoplay a cada 3 segundos
    setInterval(autoPlay, 3000);

    // Vincular os botões de navegação manual
    document.querySelector('.prev').addEventListener('click', function() {
        moveScreenshot(-1); // Voltar uma imagem
    });

    document.querySelector('.next').addEventListener('click', function() {
        moveScreenshot(1); // Avançar uma imagem
    });
});

// fim parte da pag jogo

// pause + tema escuro

document.addEventListener('DOMContentLoaded', function () {
    const themeToggle = document.getElementById('theme-toggle');
    const audio = document.getElementById('audio');
    const pauseMusicButton = document.getElementById('pause-music');
    
    // Verifica a preferência de tema do usuário no localStorage
    if (localStorage.getItem('theme') === 'dark') {
        document.body.classList.add('dark-theme');
        themeToggle.textContent = '🌞'; // Mudar o ícone para o tema claro
    } else {
        document.body.classList.remove('dark-theme');
        themeToggle.textContent = '🌙'; // Mudar o ícone para o tema escuro
    }

    // Alternar entre os temas e atualizar a preferência no localStorage
    themeToggle.addEventListener('click', () => {
        document.body.classList.toggle('dark-theme');

        if (document.body.classList.contains('dark-theme')) {
            localStorage.setItem('theme', 'dark');
            themeToggle.textContent = '🌞'; // Ícone do tema claro
        } else {
            localStorage.setItem('theme', 'light');
            themeToggle.textContent = '🌙'; // Ícone do tema escuro
        }
    });

    // Função para pausar a música
    if (pauseMusicButton) {
        pauseMusicButton.addEventListener('click', () => {
            if (audio.paused) {
                audio.play();
                pauseMusicButton.textContent = 'Pausar Música';
            } else {
                audio.pause();
                pauseMusicButton.textContent = 'Retomar Música';
            }
        });
    }
});
