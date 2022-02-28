mergeInto(LibraryManager.library, {
  debugLog: function (param) {
    console.log(Pointer_stringify(param));
  },
  SendMsg2Web:function(data){
    UnityListener(Pointer_stringify(data));
  }
});