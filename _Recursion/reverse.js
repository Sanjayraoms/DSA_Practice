// Write a recursive function called reverse which accepts a string and returns a new string in reverse.
console.log(reverse('awesome'));
console.log(reverse('rithmschool')) // 'loohcsmhtir'
function reverse(str){
   if(str.length === 0) return "";
   let rev = str[str.length - 1];
   return rev.concat(reverse(str.substring(0,str.length - 1)));
}