<template>
  <v-container class="leadership-width">
    <v-row class="text-center">
      <v-col class="mb-4">
        <h2 class="headline font-weight-bold mb-4">Leaderboard Data</h2>
      </v-col>
    </v-row>
    <v-row v-for="user of users" :key="user.userId" class="text-center card-display">      
      <v-col  class="mb-4 vertical-center">
        {{ user.sortOrder }} 
      </v-col>
      <v-col  class="mb-4">
        <img :src="user.thumbnail" width="80" /> 
      </v-col>
      <v-col  class="mb-4 vertical-center">
        {{ user.firstName }} 
        {{ user.lastName }} 
      </v-col>
      <v-col  class="mb-4 vertical-center font-weight-black text-right">
        ${{ user.millions }}M
      </v-col>
      <v-col  class="mb-4 vertical-center">
        {{ user.country }}   
      </v-col>
      <v-col  class="mb-4 vertical-align-icon">
        <v-btn
          :href="'edit?id=' + user.userId"
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
      function compare(a,b){
        const winningsA = a.winnings;
        const winningsB = b.winnings;
        let comparison = 0;
        if(winningsA>winningsB) comparison = -1;
        else if (winningsA < winningsB) comparison = 1
        return comparison
      }
      try{
        const response = await axios.get(`https://localhost:44389/api/Users`)
        this.users=response.data;
        this.users.sort(compare);
        console.log(this.users)
        let order=1;
        // note - typescript is quite rightly complaining about these new fields
        // so I should really declare a new array instead of adding to the users array
        this.users.forEach(user => {
          user.sortOrder = order;
          user.millions = (Math.round(user.winnings/100000))/10
          order++;
        }) 
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
.text-right{
  margin-right:5vw;
}
.card-display{
  border:1px solid grey;
  background-color:#dddddd;
  border-radius:20px;
  margin:1vh 0;
}
.card-display:hover{
  background-color:#cccccc;
}
.leadership-width{
  width:80vw;
}
</style>
