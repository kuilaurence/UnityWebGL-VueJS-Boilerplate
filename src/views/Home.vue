<template>
  <div class="">
    <div class="">
      <!--
      The Unity Container.
      Look in the src of npm-modules/vue-unity-webgl/ after npm installing for the mechanics of this custom component   eg.  Fullscreen
      -->
      <unity
        src="/Build/Build.json"
        width="1000"
        height="600"
        unityLoader="/Build/UnityLoader.js" ref="myInstance"
      >
      </unity>
    </div>
    <div class="">
      <input v-model="textInput" placeholder="Enter a string to send to Unity">
      <button @click="sendText">
        Send a string to Unity
      </button>
    </div>
  </div>
</template>
<script>
import Unity from 'vue-unity-webgl'

export default {
  name: 'home',
  components: {
    Unity
  },
  created(){
    window["UnityListener"]=(data)=>{
      console.log("UnityListener:",JSON.parse(data));
    }
  },
  data() {
    return {
      textInput: "String to send"
    }
  },
  methods: {
    sendText() {
      console.log(this.textInput)
      this.$refs.myInstance.message('WebGLListener', 'SetText', this.textInput);
    }
  }
}
</script>
