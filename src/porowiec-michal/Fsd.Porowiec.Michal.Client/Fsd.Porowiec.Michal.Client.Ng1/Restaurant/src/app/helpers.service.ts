import { Injectable } from '@angular/core';

@Injectable()
export class HelpersService {

  constructor() { }

  cutFromArray(array, object):any{
    array.forEach( (el, i) => {
      if(el == object) {
        let firstArray = array.slice(0,i);
        let secondArray = array.slice(i,array.length);
        console.log("man im here");
        secondArray.shift();

        array = firstArray.concat(secondArray);
      }
    })
    return array
  } 
}
