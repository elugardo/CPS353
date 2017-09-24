import { Component } from '@angular/core'

@Component({
    selector: 'websites-list',
    //templateUrl: 'app/websites/websites-list.component.html'
    template:`
<div>
    <h1>Web sites</h1>
    <hr />
    <website-thumbnail [website]="website1" (eventClick)="websiteClick($event)"></website-thumbnail>
</div>
`
})

export class WebsitesListComponent {
    website1 = {
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
    }

    websiteClick(data) {
        console.log("the data is: " + data)
    }
}