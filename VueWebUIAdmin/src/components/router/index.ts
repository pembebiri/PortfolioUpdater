import { createRouter, createWebHistory } from 'vue-router'

// Bileşenleri import edin

import AdminSkills from '../components/admin/AdminSkills.vue'
import Login from '../components/admin/Login.vue'
import AdminProjects from '../admin/AdminProjects.vue'

// Yönlendirme için yolları tanımlayın
const routes = [
  { path: '/login', component: Login },
  { path: '/adminskills', component: AdminSkills },
  { path: '/adminprojects', component: AdminProjects }
]

// Router'ı oluşturun
const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router
