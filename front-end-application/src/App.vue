<template>
  <v-app>
    <v-app-bar
      app
      color="primary"
      dark
    >
    <div class="d-flex align-center">
      <v-btn
        href="/"
        target="_self"
        text
      >
        <v-img
            alt="Vuetify Logo"
            class="shrink mr-2"
            contain
            src="https://www.fourwindsinteractive.com/assets/favicon-ff740a3695866e2bb78e409a4acefd4282a7e8d235fa4c85d1615362b724021f.ico"
            transition="scale-transition"
            width="40"
          />
      </v-btn>
      
      <v-btn
        href="/home"
        target="_self"
        text
      >
        <span class="mr-2">Home</span>
      </v-btn>

      <v-btn
        href="/leaderboard"
        target="_self"
        text
      >
        <span class="mr-2">Leaderboard</span>
      </v-btn>

      <v-btn
        href="/add"
        target="_self"
        text
      >
        <span class="mr-2">+ New User</span>
      </v-btn>

    </div>

      <v-spacer></v-spacer>

      <v-btn
        href="/leaderboard"
        target="_self"
        text
      >
        <span class="mr-2">Leaderboard</span>
        <v-icon>mdi-open-in-new</v-icon>
      </v-btn>
    </v-app-bar>

    <v-main>
      <router-view></router-view>
    </v-main>
  </v-app>
</template>

<script lang="ts">
import Vue from 'vue';

export default Vue.extend({
  name: 'App',

  data: () => ({
    menu: [ 
      {

      }

    ]
  }),
});
</script>
