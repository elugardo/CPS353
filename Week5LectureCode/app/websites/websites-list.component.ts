import { Component,OnInit } from '@angular/core'
import {WebsiteService} from './shared/website.service'

@Component({
    selector: 'websites-list',
    //templateUrl: 'app/websites/websites-list.component.html'
    template:`
<div>
    <h1>Web sites</h1>
    <hr />
    <div class="row">
        <div *ngFor="let website of websites" class="col-md-5">
            <website-thumbnail  [website]="website" (eventClick)="websiteClick($event)"></website-thumbnail>
        </div>
    </div>
</div>
`
})

export class WebsitesListComponent implements OnInit {
    websites:any[]
    constructor(private websiteService: WebsiteService) {
    }

    ngOnInit() {
        this.websites = this.websiteService.getWebsites()

    }

    websiteClick(data) {
        console.log("the data is: " + data)
    }
}