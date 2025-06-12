<script setup>
import pythonImg from '@/assets/imgs/python.png'
import nodejsImg from '@/assets/imgs/nodejs.png'
import jsImg from '@/assets/imgs/java-script.png'
</script>

<template>
  <section id="skills" class="skills">
    <div class="grid-container">
      <div class="grid-item">
        <img :src="pythonImg" alt="Python" class="icon" />
      </div>
      <div class="grid-item">
        <img :src="nodejsImg" alt="Node.js" class="icon" />
      </div>
      <div class="grid-item">
        <img :src="jsImg" alt="JavaScript" class="icon" />
      </div>
    </div>
  </section>
</template>

<style>
  .grid-container {
    display: grid;
    grid-template-columns: repeat(4, 1fr); /* 4 sütun oluştur */
    gap: 2px; /* Elemanlar arasına boşluk bırak */
  }

  .grid-item {
    background-color: white;
    padding: 10px; /* Dış boşluğu azaltarak ikonların daha belirgin görünmesini sağla */
    text-align: center;
    box-sizing: border-box; /* Elemanlar kutu modeline göre hesaplanır */
  }

  .icon {
    width: 100px; /* İkon genişliğini ayarla */
    height: 100px; /* İkon yüksekliğini ayarla */
    object-fit: contain; /* İkonların orantısını koru */
  }
</style>
