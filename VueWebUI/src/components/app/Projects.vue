<template>
  <section id="projects" class="projects">
    <div class="scroll-container">
      <button class="scroll-button left" @click="scrollLeft">←</button>
      <div class="scroll-wrapper">
        <ul class="project-list">
          <li v-for="project in projects" :key="project.id" class="project-card">
            <h3>{{ project.title }}</h3>
            <p>{{ project.description }}</p>
          </li>
        </ul>
      </div>
      <button class="scroll-button right" @click="scrollRight">→</button>
    </div>
  </section>
</template>

<script setup>
import { ref } from 'vue'
let id = 1

const projects = ref([
  { id: id++, title: 'Project 1', description: 'Description of project 1' },
  { id: id++, title: 'Project 2', description: 'Description of project 2' },
  { id: id++, title: 'Project 2', description: 'Description of project 2' },
  { id: id++, title: 'Project 2', description: 'Description of project 2' }
  // Diğer projeler
])

const scrollContainer = (ref < HTMLElement) | (null > null)

function scrollLeft() {
  if (scrollContainer.value) {
    scrollContainer.value.scrollBy({ left: -300, behavior: 'smooth' })
  }
}

function scrollRight() {
  if (scrollContainer.value) {
    scrollContainer.value.scrollBy({ left: 300, behavior: 'smooth' })
  }
}
</script>

<style scoped>
.projects {
  background-image: url('src/components/gif/2iiH.gif');
}
/* Konteyner ve buton stili */
.scroll-container {
  display: flex;
  align-items: center;
  position: relative;
  min-height: 100vh; /* Sayfa yüksekliğini en az 100vh yapar */
  margin-left: 350px;
  margin-right: 350px;
  overflow: hidden;
}
.scroll-wrapper {
  width: 100%;
}
.scroll-wrapper::-webkit-scrollbar {
  overflow: hidden;
}

.project-list {
  display: flex;
  padding: 0;
  list-style-type: none;
}

.project-card {
  color: #1f3d40;
  background: rgba(255, 255, 255, 0.5);
  background-color: #f6ffaa;
  border: 1px solid #ddd;
  border-radius: 8px;
  padding: 16px;
  margin: 8px;
  width: 400 px; /* Kart genişliği */
  height: 200 px;
  box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
}

.project-card:hover {
  transform: scale(1.2);
  box-shadow: 0 3px 5px rgba(0, 0, 0, 0.4);
}
.scroll-button {
  background-color: #007bff;
  border: none;
  color: white;
  box-shadow: 2px 3px 8px rgba(0, 0, 0, 0.4);
  font-size: 1.2rem;
  padding: 10px;
  cursor: pointer;
  position: absolute;
  top: 50%;
  transform: translateY(-50%);
  z-index: 1;
}

.scroll-button.left {
  left: 3px;
  border-radius: 20px;
  background-color: #022840;
  color: white;
  opacity: 0.7;
}

.scroll-button.right {
  right: 3px;
  border-radius: 20px;
  background-color: #022840;
  color: white;
  opacity: 0.7;
}

.scroll-button:hover {
  background-color: #011928;
}

@media (min-width: 1024px) {
}
</style>
