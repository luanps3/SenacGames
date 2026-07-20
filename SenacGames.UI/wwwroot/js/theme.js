/**
 * theme.js - Sistema de Alternância Light/Dark Mode
 * SenacGames
 */

(function () {
    // 1. Definir o tema inicial imediatamente para evitar FOUC (Flash of Unstyled Content)
    const storedTheme = localStorage.getItem('theme');
    const systemPrefersDark = window.matchMedia && window.matchMedia('(prefers-color-scheme: dark)').matches;
    
    // O sistema por padrão utiliza Light Theme (devido às variáveis no :root no CSS)
    // Então só ativamos o dark se for explicitamente salvo como 'dark' ou se for a preferência do SO
    let initialTheme = 'light';
    if (storedTheme === 'dark' || (!storedTheme && systemPrefersDark)) {
        initialTheme = 'dark';
    }

    // Aplica o tema na raiz do documento
    document.documentElement.setAttribute('data-theme', initialTheme);

    // 2. Lógica para alternar o tema e atualizar UI quando o DOM carregar
    window.toggleTheme = function() {
        const currentTheme = document.documentElement.getAttribute('data-theme');
        const newTheme = currentTheme === 'dark' ? 'light' : 'dark';
        
        document.documentElement.setAttribute('data-theme', newTheme);
        localStorage.setItem('theme', newTheme);
        
        updateThemeIcons(newTheme);
    };

    function updateThemeIcons(theme) {
        const icons = document.querySelectorAll('.theme-toggle-icon');
        icons.forEach(icon => {
            if (theme === 'dark') {
                icon.classList.remove('bi-moon-fill');
                icon.classList.add('bi-sun-fill');
                icon.style.color = 'var(--warning)';
            } else {
                icon.classList.remove('bi-sun-fill');
                icon.classList.add('bi-moon-fill');
                icon.style.color = 'var(--on-surface-variant)'; // Um tom escuro para o light mode
            }
        });
    }

    // 3. Atualizar ícones assim que a página carregar
    document.addEventListener('DOMContentLoaded', () => {
        updateThemeIcons(initialTheme);
    });

})();
