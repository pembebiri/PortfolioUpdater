<template>
  <section id="skills" class="skills">
  <div class="grid-container">
    <div class="grid-item">
      <img src="C:\Users\Zehra Karakaya\Desktop\PortfolioUpdater\VueWebUI\src\assets\imgs\python.png" alt="Python" class="icon" />
    </div>
    <div class="grid-item">
      <img src="C:\Users\Zehra Karakaya\Desktop\PortfolioUpdater\VueWebUI\src\assets\imgs\nodejs.png" alt="Node.js" class="icon" />
    </div>
    <div class="grid-item">
      <img src="C:\Users\Zehra Karakaya\Desktop\PortfolioUpdater\VueWebUI\src\assets\imgs\java-script.png" alt="JavaScript" class="icon" />
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
