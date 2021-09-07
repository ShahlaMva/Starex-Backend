$(document).ready(function() {
//input when click remove border 
$(document).on("focus",".register-input",function(){
    $(this).css('outline','none');


});
//register page tabs
$(document).on("click",".tabs a",function(e){
e.preventDefault();

if($(this).parent().attr("id")=="business"){
    $(this).parent().addClass('active');
    
        $("#person").removeClass("active");   
     $("#business1").removeClass("d-none");
       $("#person1").hide();
   
}else{
    $(this).parent().addClass('active');
  $("#business").removeClass("active");
    $("#business1").addClass("d-none");
  
    $("#person1").show();
  
}

});
//shop tabs
$(document).on("click",".tabs-list .tab-shop a",function(e){
e.preventDefault();
$(this).parent().addClass("border");
 $(this).parent().siblings().removeClass("border");
 if($(this).parent().attr("id")=="chine"){
   $("#chine-content").removeClass("d-none");
   $("#chine-content").siblings().addClass("d-none");
 }else if($(this).parent().attr("id")=="germany"){
  $("#germany-content").removeClass("d-none");
  $("#germany-content").siblings().addClass("d-none");
 }else if($(this).parent().attr("id")=="turkey"){
  $("#turkey-content").removeClass("d-none");
  $("#turkey-content").siblings().addClass("d-none");
 }else{
  $("#usa-content").removeClass("d-none");
  $("#usa-content").siblings().addClass("d-none");
 }



})

});