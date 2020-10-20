<template>
  <v-container>
    <v-row class="text-center">
      <v-col class="mb-4">
        <h2 class="headline font-weight-bold mb-4">Leaderboard Data</h2>
      </v-col>
    </v-row>
    <v-row v-for="user of users" :key="user.userId" class="text-center">
      <v-col  class="mb-4 align-middle vertical-center">
        {{ user.userId }} 
      </v-col>
      <v-col  class="mb-4 vertical-center">
        {{ user.username }} 
      </v-col>
      <v-col  class="mb-4">
        <img :src="user.thumbnail" width="80" /> 
      </v-col>
      <v-col  class="mb-4 vertical-center">
        {{ user.firstName }} 
        {{ user.lastName }} 
      </v-col>
      <v-col  class="mb-4 vertical-center">
        {{ user.winnings }} 
      </v-col>
      <v-col  class="mb-4 vertical-center">
        {{ user.country }}   
      </v-col>
      <v-col  class="mb-4 vertical-align-icon">
        <v-btn
          href="/"
          target="_self"
          text
          >
          <v-img
              alt="Vuetify Logo"
              class="shrink mr-2"
              contain
              src="https://cdn.onlinewebfonts.com/svg/img_386644.png"
              transition="scale-transition"
              width="12"
            />
        </v-btn>
      </v-col>   
    </v-row>
  </v-container>
</template>

<script lang="ts">
  import Vue from 'vue'
  import axios from 'axios'

  export default Vue.extend({
    name: 'Leaderboard',
    data: () => ({
      info: "this is some data",
      users: []
    }),
    async created(){
      try{
        const response = await axios.get(`https://localhost:44389/api/Users`)
        console.log(response.data);
        this.users=response.data;
      }
      catch(e){
        console.error(e);
      }
    }
  })
</script>
<style scoped>
.vertical-center{
  margin-top:14px;
}
.vertical-align-icon{
  margin-top:8px
}
</style>
