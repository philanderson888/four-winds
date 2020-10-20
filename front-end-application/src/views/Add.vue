<template>
  <v-container>
    <v-row class="text-center">
      <v-col class="mb-4">
        <h2 class="headline font-weight-bold mb-4">Add User To Leaderboard</h2>
      </v-col>
    </v-row>
    <v-row class="text-center shaded">
      <v-col></v-col>
      <v-col class="mb-2 vertical-center">
        Username
      </v-col>
      <v-col  class="mb-2 vertical-center">
        <input type="text" v-model="user.username" placeholder="username" />
      </v-col>
      <v-col></v-col>
    </v-row>
    <v-row class="text-center shaded">
      <v-col></v-col>
      <v-col  class="mb-4 vertical-center">
        First Name
      </v-col>
      <v-col  class="mb-4 vertical-center">
        <input type="text" v-model="user.firstname" placeholder="first name" />
      </v-col>
      <v-col></v-col>
    </v-row>
    <v-row class="text-center shaded">
          <v-col></v-col>
      <v-col  class="mb-4 vertical-center">
        Last Name
      </v-col>
      <v-col  class="mb-4 vertical-center">
        <input type="text" v-model="user.lastname" placeholder="last name" />
      </v-col>
            <v-col></v-col>
                  
    </v-row>
    <v-row class="text-center shaded">
      <v-col></v-col>
      <v-col  class="mb-4 vertical-center">
        Thumbnail Image
      </v-col>
      <v-col  class="mb-4 vertical-center">
        <input type="text" v-model="user.thumbnail" placeholder="url of thumbnail image" />
      </v-col>
            <v-col></v-col>
                  
    </v-row>
    <v-row class="text-center shaded">
          <v-col></v-col>
      <v-col  class="mb-4 vertical-center">
        Country Of Origin
      </v-col>
      <v-col  class="mb-4 vertical-center">
        <input type="text" v-model="user.country" placeholder="country" />
      </v-col>
            <v-col></v-col>
    </v-row>
    <v-row class="text-center shaded">
          <v-col></v-col>
      <v-col  class="mb-4 vertical-center">
        Leaderboard High Score
      </v-col>
      <v-col  class="mb-4 vertical-center">
        <input type="number" v-model="user.winnings" placeholder="high score" />
      </v-col>
      <v-col></v-col>
    </v-row>
    <v-row class="text-center shaded">
      <v-col offset="1" class="mb-4 vertical-center">
        <v-btn type="submit" @click="addUser"  color="blue darken-1">Add New User</v-btn>
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
      url: 'https://localhost:44389/api/Users',
      users: [], 
      user: {}
    }),
    async created(){
      try{
        const response = await axios.get(this.url)
        console.log(response.data);
        this.users=response.data;
      }
      catch(e){
        console.error(e);
      }
    }, 
    methods:{
      async addUser(){
        console.log(this.user)
        const headers = {
          'Content-Type':'application/json'
        }
        const response = await axios.post(this.url, this.user, {
          headers: headers
        })
        console.log(response)
        location.href='/leaderboard';
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
.shaded{
  background-color: #81bae6;
}
</style>
