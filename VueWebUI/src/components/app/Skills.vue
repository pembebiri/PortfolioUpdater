<template>
  <section id="skills">
    <ul>
      <li v-for="skill in skills" :key="skill.id">
        <img :src="skill.image" :alt="skill.title" class="skill-image" />
      </li>
    </ul>
  </section>
</template>

<script setup>
import { ref } from 'vue'
import resim from 'C:/Users/Zehra Karakaya/Desktop/proje3/VueWebUI/src/assets/imgs/coding-language.png'
import resim2 from 'C:/Users/Zehra Karakaya/Desktop/proje3/VueWebUI/src/assets/imgs/document.png'
let id = 1

const skills = ref([
  {
    id: id++,
    title: '',
    image: resim
  },
  {
    id: id++,
    title: '',
    image: resim2
  }
])
</script>

<style scoped>
.skills {
  display: flex;
  flex-direction: column;
  gap: 20px;
}

.skill-item {
  display: flex;
  align-items: center;
  gap: 20px;
}

.skill-image {
  width: 100px; /* Resmin genişliği */
  height: 100px; /* Resmin yüksekliği */
  object-fit: cover; /* Resmi kapsayıcıya göre keser */
  border-radius: 8px; /* İsteğe bağlı olarak köşeleri yuvarlatır */
}
ul {
  display: inline;
}
</style>
