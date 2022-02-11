mergeInto(LibraryManager.library, {

  debugLog: function (param) {
    debug(Pointer_stringify(param));
  },
  SendTransaction:function(data){
    receiveMsgFromUnity(Pointer_stringify(data));
  }
 
});