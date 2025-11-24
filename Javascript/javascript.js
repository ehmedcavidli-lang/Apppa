// function maxOfThree(a, b, c) {
//     let max = a;           
//     if(b>max) max=b 
//     if (c > max) max = c;  
//     return max;
//   }
//   let maxnumber=maxOfThree(5,6,8)
//   console.log(maxnumber)
//   function averageOfThree(a, b, c) {
//     let average = (a+b+c)/3;           
    
//     return average;
//   }
//   console.log(averageOfThree(1,2,3))

//   function SumOfDigits(a) {
//     let sum = 0;
  
//     while (a > 0) {
//      let sonReqem =a % 10;    
//      sum+=sonReqem
//     a=(a-sonReqem)/10
//     }
  
//     return sum;
//   }
  
//   console.log(SumOfDigits(123456)); 
  
//   function IsCheck(a) {
    
//   if(a%21==0)
//       console.log("Hem 3-e hem de 7-e bolunur")
//   else 
//       console.log ("Bolunmur")  
  
  
  
    
//   }
  
// IsCheck(14); 



// function FindAge(DoqumTarixi) {
    

//     let yas =2025-DoqumTarixi

//     return yas;
// }


// console.log(FindAge(2005)); 
let arr=[1,2,3,4,5,6,7,8]
function ChangeMinToMax(arr) {
    
    let minindex=0
    let maxindex=0

    for (let i = 0; i < arr.length; i++) {
       if (arr[i]<arr[minindex]) 
       {
        minindex=i
       }
       if (arr[i]>arr[maxindex]) 
       {
        maxindex=i 
       }
       
        
    }
   let temp=arr[minindex]
   arr[minindex]=arr[maxindex]
   arr[maxindex]=temp
    return arr;
  }
  
  console.log(ChangeMinToMax(arr)); 
