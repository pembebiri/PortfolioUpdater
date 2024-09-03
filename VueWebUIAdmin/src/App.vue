<!-- src/views/AdminLayout.vue -->
<template>
  <div id="admin-section" class="container">
    <header>
      <AdminNavBar />
    </header>
    <main>
      <RouterView />
    </main>
    <footer>
      <p>&copy; 2024 Admin Panel</p>
    </footer>
  </div>
</template>

<script setup>
import AdminNavBar from '@/components/admin/AdminNavBar.vue'
</script>

<style scoped>
/* Admin Layout stilleri */
</style>
