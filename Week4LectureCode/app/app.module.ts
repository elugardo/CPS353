import { NgModule } from '@angular/core'
import { BrowserModule } from '@angular/platform-browser'
import { WebsitesAppComponent } from './websites-app.component'
import { WebsitesListComponent } from './websites/websites-list.component'
import { WebsiteThumbnailComponent } from './websites/website-thumbnail.component' 

@NgModule({
    imports: [BrowserModule],
    declarations: [WebsitesAppComponent, WebsitesListComponent, WebsiteThumbnailComponent ],
    bootstrap: [WebsitesAppComponent]
})

export class AppModule {
}



