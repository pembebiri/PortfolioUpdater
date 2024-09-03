<template>
  <nav class="nav">
    <ul>
      <li><a href="#login">Login</a></li>
      <li><a href="#adminprojects">Projects</a></li>
      <li><a href="#adminskills">Skills</a></li>
    </ul>
  </nav>
</template>

<script setup>
// NavBar bileşeninin içeriği
</script>

<style scoped>
.nav {
  position: fixed; /* Navbar'ı sabitlemek için */
  top: 0;
  left: 0;
  height: 100vh; /* Tam yükseklik */
  width: 250px; /* Genişlik ayarı */
  background-color: #f6ffaa;
  color: #f6ffaa;
  display: flex;
  flex-direction: column;
  padding: 20px;
}

.nav ul {
  list-style: none;
  padding: 0;
  margin: 0;
}

.nav li {
  padding-top: 3px;
  padding-bottom: 3px;
  margin: 20px;
}
.nav li:hover {
  background-color: #dfea7f;
  box-shadow: 1px 2px 2px rgb(157, 157, 157);
  padding: 2ps;
  border-radius: 4px;
}

.nav a {
  color: #1f3d40;
  font-family: Arial, Helvetica, sans-serif;
  text-decoration: none;
  font-size: 1 rem;
  padding: 20px;
}

.navbar a:hover {
  text-decoration: none;
}
</style>
