/*
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
            musica: "musicas/tony-country.mp3",
            curriculo: "curriculos/curriculoHtml/index.html" // Link para o currículo
        },
        {
            nome: "Wecton Santos",
            info: "Programador",
            musica: "musicas/wecton.mp3",
            curriculo: "curriculos/projeto/index.html" // Link para o currículo

        }
    ];

    document.querySelectorAll('.imgPedro, .imgWecton').forEach((img, index) => {
        img.addEventListener('click', () => {
            popupName.textContent = pessoas[index].nome;
            popupInfo.textContent = pessoas[index].info;
            curriculoLink.href = pessoas[index].curriculo; // Atualiza o link do currículo
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
*/

document.addEventListener("DOMContentLoaded", function() {
    const popup = document.getElementById("popup");
    const popupName = document.getElementById("popup-name");
    const popupInfo = document.getElementById("popup-info");
    const curriculoLink = document.getElementById("curriculo-link"); // Link para o currículo
    const closeBtn = document.querySelector(".close-btn");
    const audio = document.getElementById("audio");

    const pessoas = [
        {
            nome: "Pedro Henrique Morereira",
            info: "Programador",
            musica: "musicas/tony-country.mp3",
            curriculo: "curriculos/curriculoHtml/index.html" // Link para o currículo
        },
        {
            nome: "Wecton Santos",
            info: "Natural de Santos e residente de Cubatão, Wecton tem formações de Técnico em Programação de Jogos e Técnico em Informática e Suporte pela Etec de Cubatão, além de ser aluno do 4º Semestre em Engenharia de Computação na Universidade Santa Cecília. Apaixonado pelo Santos Futebol Clube e cinefílo assíduo, possui habilidades de programação em variadas linguagens e tem como objetivo trabalhar na área de desenvolvimento de softwares.",
            musica: "musicas/wecton.mp3",
            curriculo: "curriculos/projeto/index.html" // Link para o currículo
        }
    ];

    // Evento de clique para mostrar o pop-up
    document.querySelectorAll('.imgPedro, .imgWecton').forEach((img, index) => {
        img.addEventListener('click', () => {
            // Atualiza o conteúdo do pop-up com os dados da pessoa selecionada
            popupName.textContent = pessoas[index].nome;
            popupInfo.textContent = pessoas[index].info;
            curriculoLink.href = pessoas[index].curriculo; // Atualiza o link do currículo
            popup.style.display = "block"; // Mostra o pop-up

            // Reproduz a música correspondente
            audio.src = pessoas[index].musica;
            audio.currentTime = 0; 
            audio.play(); 
        });
    });

    // Evento para fechar o pop-up
    closeBtn.addEventListener("click", function() {
        popup.style.display = "none";
        audio.pause(); // Pausa a música
    });

    // Fecha o pop-up se o usuário clicar fora dele
    window.addEventListener("click", function(event) {
        if (event.target == popup) {
            popup.style.display = "none";
            audio.pause(); // Pausa a música
        }
    });

    // Função para exibir texto das seções
    window.addEventListener('scroll', () => {
        const elements = document.querySelectorAll('.sobre, .apresentacao, .quemSomos');
        elements.forEach(element => {
            if (element.getBoundingClientRect().top < window.innerHeight) {
                element.classList.add('visible');
            }
        });
    });

    // Remover o loading após a página ser carregada
    window.onload = () => {
        document.getElementById('loading').style.display = 'none';
    };

    // Função para o carrossel de imagens
    let currentIndex = 0;
    const images = document.querySelectorAll('.carousel-image');
    const totalImages = images.length;

    function moveScreenshot(step) {
        images[currentIndex].classList.remove('active');
        currentIndex = (currentIndex + step + totalImages) % totalImages;
        images[currentIndex].classList.add('active');
    }

    function autoPlay() {
        moveScreenshot(1);
    }

    setInterval(autoPlay, 3000); // Avançar a cada 3 segundos

    document.querySelector('.prev').addEventListener('click', function() {
        moveScreenshot(-1);
    });

    document.querySelector('.next').addEventListener('click', function() {
        moveScreenshot(1);
    });

    // Lógica para alternar entre os temas
    const themeToggle = document.getElementById('theme-toggle');
    const pauseMusicButton = document.getElementById('pause-music');
    
    if (localStorage.getItem('theme') === 'dark') {
        document.body.classList.add('dark-theme');
        themeToggle.textContent = '🌞'; 
    } else {
        document.body.classList.remove('dark-theme');
        themeToggle.textContent = '🌙'; 
    }

    themeToggle.addEventListener('click', () => {
        document.body.classList.toggle('dark-theme');
        if (document.body.classList.contains('dark-theme')) {
            localStorage.setItem('theme', 'dark');
            themeToggle.textContent = '🌞'; 
        } else {
            localStorage.setItem('theme', 'light');
            themeToggle.textContent = '🌙'; 
        }
    });

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


// audio interativo p mulecada
document.querySelector('.theme-toggle').addEventListener('mouseover', function() {
    const audio = new Audio('caminho-do-som.mp3');
    audio.play();
});
