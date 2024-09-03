<template>
  <section id="aboutme">
    <div class="portfolio-entry">
      <div class="text-section">
        <h1 class="green">{{ msg }}</h1>
        <h3>
          The training I received and the projects I carried out in this field demonstrate how I
          interact with this exciting technology. By focusing on continuous improvement in both
          hardware and software fields, I try to produce unique solutions in IoT projects. I
          received various trainings including embedded IoT systems and IoT security, and during
          this period, I carried out projects on the use of IoT in M2M and Autonomous vehicles. Each
          project provided an opportunity to explore how we can solve problems using the power of
          IoT. In the future, I would like to participate in more innovative projects related to the
          Internet of Things and study in depth in this field. If you share the same passion as me
          or know projects we can work on together, please contact me via
          <strong><b>zehrakarakayabm@gmail.com</b></strong
          >.
        </h3>
      </div>
      <div class="gif-section">
        <img
          src="C:\Users\Zehra Karakaya\Desktop\proje3\VueWebUI\src\components\gif\905629f91b2cc4b8931d44e1881c9275.gif"
          alt="Decorative GIF"
        />
      </div>
      <div class="button-section">
        <button class="flying-button"><a href="#projects">More</a></button>
      </div>
    </div>
  </section>
</template>

<script setup lang="ts">
defineProps<{
  msg: string
}>()
</script>

<style scoped>
html,
body {
  margin: 0;
  height: 100%;
}
.portfolio-entry {
  color: #1f3d40;
  background: rgba(255, 255, 255, 0.5);
  background-color: #f6ffaa;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  text-align: center;
  padding: 20px;
  position: relative;
  min-height: 100vh; /* Sayfa yüksekliğini en az 100vh yapar */
}

.text-section {
  margin-bottom: 20px;
}

.gif-section {
  margin-bottom: 50px;
}

.gif-section img {
  width: 350px; /* GIF'in boyutunu buradan ayarlayabilirsiniz */
  height: auto;
}

.button-section {
  position: relative;
  margin-bottom: 50px;
}

.flying-button {
  z-index: 900;
  background-color: #022840;
  color: white;
  opacity: 0.7;
  border: none;
  padding: 15px 30px;
  font-size: 1.2rem;
  border-radius: 5px;
  cursor: pointer;
  position: relative;
  animation: fly 3s infinite; /* Uçma efekti */
  box-shadow: 2px 4px 8px rgba(0, 0, 0, 0.5);
}

.flying-button:hover {
  background-color: #011928;
}

@keyframes fly {
  0% {
    transform: translateY(0);
  }
  50% {
    transform: translateY(-20px);
  }
  100% {
    transform: translateY(0);
  }
}

@media (min-width: 1024px) {
  .portfolio-entry {
    margin-top: 20px;
    flex-direction: row;
    justify-content: space-between;
    text-align: left;
    .portfolio-entry {
      position: relative;
      /* Diğer stiller */
    }
  }

  .text-section {
    flex: 1;
    margin-right: 20px;
  }

  .gif-section {
    flex: 1;
    display: flex;
    align-items: center;
    justify-content: center;
    margin-bottom: 2px;
  }

  .button-section {
    position: absolute;
    bottom: 10px;
    width: 100%;
    text-align: center;
  }

  a {
    color: white;
    text-decoration: none;
  }
}
</style>
