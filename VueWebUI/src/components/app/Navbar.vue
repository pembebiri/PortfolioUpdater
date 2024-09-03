<template>
  <nav>
    <ul>
      <li><a href="#aboutme">About Me</a></li>
      <li><a href="#projects">Projects</a></li>
      <li><a href="#skills">Skills</a></li>
      <li><a href="#contact">Contact</a></li>
    </ul>
  </nav>
</template>

<script setup>
// NavBar bileşeninin içeriği
</script>

<style scoped>
nav {
  position: fixed;
  top: 0; /* Üstten sabitler */
  left: 0; /* Soldan sabitler */
  width: 100%; /* Tam genişlik */
  z-index: 1000; /* Diğer öğelerin üstünde kalması için */
  background-color: #f6ffaa;
  box-shadow: 0 3px 8px rgba(0, 0, 0, 0.3);
}
nav ul {
  list-style-type: none;
  padding: 0;
}
nav li {
  display: inline;
  margin: 0 10px;
}
nav a {
  color: #333;
  text-decoration: none;
}
</style>
