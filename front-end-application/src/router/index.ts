import Vue from 'vue'
import VueRouter, { RouteConfig } from 'vue-router'
import Home from '../views/Home.vue'
import Leaderboard from '../views/Leaderboard.vue'
import Edit from '../views/Edit.vue'
import Add from '../views/Add.vue'

Vue.use(VueRouter)

const routes: Array<RouteConfig> = [
  {     path: '/',      name: 'Home' , component: Home   },
  {     path: '/leaderboard',  name: 'Leaderboard' , component: Leaderboard   },
  {     path: '/edit',  name: 'Edit' , component: Leaderboard  },
  {     path: '/add',  name: 'Add' , component: Add   },
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
