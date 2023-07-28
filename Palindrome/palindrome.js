// Write a fucntion that checks whether a word or phrase is a palindrome.

function palindrome(str) {
  // remove all non-alphanumeric characters
  let newStr = str.replace(/[^0-9a-z]/gi, '');
  // reverse the string
  let reverseStr = newStr.split('').reverse().join('');
  // compare the two strings
  return newStr === reverseStr;
}