import { NgModule } from '@angular/core'
import { BrowserModule } from '@angular/platform-browser'
import { WebsitesAppComponent } from './websites-app.component'
import { WebsitesListComponent } from './websites/websites-list.component'
import { WebsiteThumbnailComponent } from './websites/website-thumbnail.component'
import { NavbarComponent } from './nav/navbar.component' 
import { WebsiteService} from './websites/shared/website.service'

@NgModule({
    imports: [BrowserModule],
    declarations: [WebsitesAppComponent, WebsitesListComponent, WebsiteThumbnailComponent, NavbarComponent],
    providers: [WebsiteService],
    bootstrap: [WebsitesAppComponent]
})

export class AppModule {
}



