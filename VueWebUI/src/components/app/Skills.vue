<template>
<div class="grid-container">
  <div class="grid-item">
    <img src="C:\Users\Zehra Karakaya\Desktop\PortfolioUpdater\VueWebUI\src\assets\imgs\python.png" alt="Image 11" />
  </div>
  <div class="grid-item">
    <img src="C:\Users\Zehra Karakaya\Desktop\PortfolioUpdater\VueWebUI\src\assets\imgs\nodejs.png" alt="Image 11" />
  </div>
  <div class="grid-item">
    <img src="C:\Users\Zehra Karakaya\Desktop\PortfolioUpdater\VueWebUI\src\assets\imgs\java-script.png" alt="Image 11" />
  </div>
  <div class="grid-item">4</div>
  <div class="grid-item">5</div>
  <div class="grid-item">6</div>
  <div class="grid-item">6</div>
  <div class="grid-item">6</div>
  <div class="grid-item">6</div>
  <div class="grid-item">6</div>
  <div class="grid-item">6</div>

</div>
</template>

<style>
  .grid-container {
    display: grid;
    grid-template-columns: repeat(4, 1fr); /* 4 sütun oluştur */
    gap: 10px; /* Elemanlar arasına boşluk bırak */
  }

  .grid-item {
    background-color: white;
    padding: 20px;
    text-align: center;
    box-sizing: border-box; /* Elemanlar kutu modeline göre hesaplanır */
  }
</style>
