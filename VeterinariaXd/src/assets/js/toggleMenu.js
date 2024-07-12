// src/assets/js/menu-toggle.js
function toggleMenu() {
  const menu = document.getElementById('menu');
  if (menu) {
    menu.classList.toggle('show');
  }
}

// Hacer la función globalmente accesible
window.toggleMenu = toggleMenu;
