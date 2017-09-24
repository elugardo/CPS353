"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var WebsitesListComponent = (function () {
    function WebsitesListComponent() {
        this.website1 = {
            id: 1,
            name: 'Blogger',
            description: 'Blogger is a blog publishing service that allows multi-user blogs with time-stamped entries. It was developed by Prya Labs, which wa bought by Google in 2003. generally the blogs are hosted by google in a subdomain of blogger.com. Bloggs can also be hsoted in the registered custom domain of the blogger (like www.example.com) A user can have up to 100 blogs per account',
            createdDate: '9/26/2003',
            createdTime: '10:00 am',
            membershipFee: 12.99,
            ownerAddress: {
                address: '1 First Street',
                city: 'Boston',
                country: 'US'
            }
        };
    }
    WebsitesListComponent.prototype.websiteClick = function (data) {
        console.log("the data is: " + data);
    };
    return WebsitesListComponent;
}());
WebsitesListComponent = __decorate([
    core_1.Component({
        selector: 'websites-list',
        //templateUrl: 'app/websites/websites-list.component.html'
        template: "\n<div>\n    <h1>Web sites</h1>\n    <hr />\n    <website-thumbnail [website]=\"website1\" (eventClick)=\"websiteClick($event)\"></website-thumbnail>\n</div>\n"
    })
], WebsitesListComponent);
exports.WebsitesListComponent = WebsitesListComponent;
//# sourceMappingURL=websites-list.component.js.map