import { Component, Input,Output,EventEmitter } from '@angular/core'

@Component({
    selector: 'website-thumbnail',
    //templateUrl: 'app/websites/website-thumbnail.component.html'
    template:`
<div class="well hoverwell thumbnail">
    <h2>{{website.name}}</h2>
    <div>Created Date: {{website.createdDate}}</div>
    <div>Time: {{website.createdTime}}</div>
    <div>Description: {{website.description}}</div>
    <div>Fee: \${{ website.membershipFee }}</div>
    <div>
    <span>{{website.ownerAddress.address}}</span>
    <span>&nbsp;</span>
    <span>{{website.ownerAddress.city}}</span>, <span>{{website.ownerAddress.country}}</span>
    </div>
    
    <button class="btn btn-primary" (click)="handleMyClick()">Click me!</button>
    </div>
`
})

export class WebsiteThumbnailComponent {
    @Input() website: any
    @Output() eventClick = new EventEmitter()

    handleMyClick() {
        this.eventClick.emit(this.website.name)
    }
}