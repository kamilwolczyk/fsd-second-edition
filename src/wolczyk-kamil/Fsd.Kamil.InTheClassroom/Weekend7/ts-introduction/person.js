"use strict";
exports.__esModule = true;
var Person = /** @class */ (function () {
    function Person(firstName, lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }
    Person.prototype.sayHello = function () {
        return "My name is " + this.firstName + " " + this.lastName;
    };
    return Person;
}());
exports.Person = Person;
