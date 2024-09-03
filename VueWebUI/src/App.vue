<template>
  <div id="app-section" class="container">
    <NavBar />
    <main class="main-content">
      <AboutMe />
      <Projects />
      <Skills />
      <Contact />
    </main>
    <Footer />
  </div>
</template>

<script setup>
import NavBar from '@/components/app/Navbar.vue'
import AboutMe from '@/components/app/AboutMe.vue'
import Projects from '@/components/app/Projects.vue'
import Skills from '@/components/app/Skills.vue'
import Contact from '@/components/app/Contact.vue'
import Footer from '@/components/app/Footer.vue'
</script>

<style>
.container {
  display: flex;
  flex-direction: column;
  min-height: 100vh;
}

.main-content {
  flex: 1;
}
</style>
