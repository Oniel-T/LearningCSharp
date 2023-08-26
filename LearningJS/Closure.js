var sum = function (a) {
  console.log(`Value of a: ${a}`);
  var c = 4;
  return function (b) {
    return a + b + c;
  };
}

var anotherFunction = sum(10);
console.log(anotherFunction(5)) //This will print 19
//So we get to know that this does store the value internally and doesn't delete it as other programming languages(lexical scope)