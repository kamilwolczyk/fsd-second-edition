"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
exports.__esModule = true;
var person_1 = require("./person");
var Employee = /** @class */ (function (_super) {
    __extends(Employee, _super);
    function Employee(firstName, lastName, companyName) {
        var _this = _super.call(this, firstName, lastName) || this;
        _this.companyName = companyName;
        return _this;
    }
    Employee.prototype.sayHello = function () {
        return this.firstName + " and I am working in " + this.companyName;
    };
    return Employee;
}(person_1.Person));
exports.Employee = Employee;
