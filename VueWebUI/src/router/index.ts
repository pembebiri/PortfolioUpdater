import { createRouter, createWebHistory } from 'vue-router'

// Bileşenleri import edin
import AboutMe from '../components/app/AboutMe.vue'
import Projects from '../components/app/Projects.vue'
import Skills from '../components/app/Skills.vue'
import Contact from '../components/app/Contact.vue'

// Yönlendirme için yolları tanımlayın
const routes = [
  { path: '/aboutme', commponent: AboutMe },
  { path: '/projects', component: Projects },
  { path: '/skills', component: Skills },
  { path: '/contact', component: Contact }
]

// Router'ı oluşturun
const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router
