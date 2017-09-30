import { Injectable } from '@angular/core'
@Injectable()

export class WebsiteService
{
    getWebsites() {
        return WEBSITES;
    }

    
}

const WEBSITES =

[
    {
        id: 1,
        description: 'Blogger is a blog publishing service that allows multi-user blogs with time-stamped entries. It was developed by Prya Labs, which wa bought by Google in 2003. generally the blogs are hosted by google in a subdomain of blogger.com. Bloggs can also be hsoted in the registered custom domain of the blogger (like www.example.com) A user can have up to 100 blogs per account',
        createdDate: '9/26/2003',
        createdTime: '10:00 am',
        membershipFee: 12.99,
        imageUrl: "/app/assets/images/blogger-logo.png",
        ownerAddress: {
            address: '1 First Street',
            city: 'Boston',
            country: 'US'
        },
        authors: [
            {
                id: 1,
                name: "Peter Darwin",
                title: "Editor",
                years: 1,
                level: "Junior",
                bio: `Some description 1`,
                voters: ['bradblack', 'igorminar', 'martinfowler']
            },
            {
                id: 2,
                name: "Jeff Gomez",
                title: "Writer",
                years: 1,
                level: "Junior",
                bio: `Another description`,
                voters: ['johnpapadapolis', 'bradblack', 'igorminar', 'martinfowler']
            },
            {
                id: 3,
                name: "Rob Stanza",
                title: "Manager",
                years: 2,
                level: "Advanced",
                bio: `A description for Rob`,
                voters: []
            },
            {
                id: 4,
                name: "Brad Black",
                title: "Director",
                years: 2,
                level: "Advanced",
                bio: `Bio for Brad`,
                voters: []
            },
            {
                id: 5,
                name: "John Papadapolis",
                title: "Developer",
                years: 2,
                level: "Beginner",
                bio: `Bio for John`,
                voters: ['bradblack', 'igorminar']
            }
        ]
    },
    {
        id: 2,
        description: 'YouTube is an American video-sharing website headquartered in San Bruno, California. The service was created by three former PayPal employees — Chad Hurley, Steve Chen, and Jawed Karim — in February 2005. ',
        createdDate: '2/14/2005',
        createdTime: '10:00 am',
        membershipFee: 12.99,
        imageUrl: "/app/assets/images/youtube-logo.jpeg",
        ownerAddress: {
            address: '22 Fisher ave',
            city: 'Boston',
            country: 'US'
        },
        authors: [
            {
                id: 1,
                name: "Christoph Precht",
                title: "Developer",
                years: 4,
                level: "Beginner",
                bio: `Bio for this`,
                voters: ['bradblack', 'igorminar']
            },
            {
                id: 2,
                name: "Angular 4 and Firebase",
                title: "David East",
                years: 3,
                level: "Junior",
                bio: `In this workshop, David East will show you how to use Angular with the new
          ultra-real-time 5D Firebase back end, hosting platform, and wine recommendation engine.`,
                voters: ['bradblack', 'igorminar', 'johnpapadapolis']
            },
            {
                id: 3,
                name: "Reading the Angular 4 Source",
                title: "Patrick Stapleton",
                years: 2,
                level: "Junior",
                bio: `Angular 4's source code may be over 25 million lines of code, but it's really 
          a lot easier to read and understand then you may think. Patrick Stapleton will talk
          about his secretes for keeping up with the changes, and navigating around the code.`,
                voters: ['martinfowler']
            },
            {
                id: 4,
                name: "Hail to the Lukas",
                title: "Lukas Ruebbelke",
                years: 1,
                level: "Beginner",
                bio: `In this session, Lukas will present the 
          secret to being awesome, and how he became the President 
          of the United States through his amazing programming skills, 
          showing how you too can be success with just attitude.`,
                voters: ['bradblack']
            }
        ]
    },
    {
        id: 3,
        description: 'Google Inc. is an American multinational technology company that specializes in Internet-related services and products. These include online advertising technologies, search, cloud computing, software, and hardware',
        createdDate: '9/4/1998',
        createdTime: '9:00 am',
        membershipFee: 2.99,
        imageUrl: "/app/assets/images/google-logo.jpeg",
        ownerAddress: {
            address: '62 Mozart ave',
            city: 'salt Lake city',
            country: 'US'
        },
        authors: [
            {
                id: 1,
                name: "How Elm Powers Angular 4",
                title: "Murphy Randle",
                years: 2,
                level: "Junior",
                bio: `We all know that Angular is written in Elm, but did you
          know how the source code is really written? In this exciting look
          into the internals of Angular 4, we'll see exactly how Elm powers
          the framework, and what you can do to take advantage of this knowledge.`,
                voters: ['bradblack', 'martinfowler', 'igorminar']
            },
            {
                id: 2,
                name: "Angular and React together",
                title: "Jamison Dance",
                years: 2,
                level: "Junior",
                bio: `React v449.6 has just been released. Let's see how to use 
          this new version with Angular to create even more impressive applications.`,
                voters: ['bradblack', 'martinfowler']
            },
            {
                id: 3,
                name: "Redux Woes",
                title: "Rob Wormald",
                years: 1,
                level: "Junior",
                bio: `Everyone is using Redux for everything from Angular to React to 
          Excel macros, but you're still having trouble grasping it? We'll take a look
          at how farmers use Redux when harvesting grain as a great introduction to 
          this game changing technology.`,
                voters: ['bradblack', 'martinfowler', 'johnpapadapolis']
            },
            {
                id: 4,
                name: "ng-wat again!!",
                title: "Shai Reznik",
                years: 1,
                level: "Beginner",
                bio: `Let's take a look at some of the stranger pieces of Angular 4,
          including neural net nets, Android in Androids, and using pipes with actual pipes.`,
                voters: ['bradblack', 'martinfowler', 'igorminar', 'johnpapadapolis']
            },
            {
                id: 5,
                name: "Dressed for Success",
                title: "Ward Bell",
                years: 2,
                level: "Beginner",
                bio: `Being a developer in 2037 is about more than just writing bug-free code. 
          You also have to look the part. In this amazing expose, Ward will talk you through
          how to pick out the right clothes to make your coworkers and boss not only
          respect you, but also want to be your buddy.`,
                voters: ['bradblack', 'martinfowler']
            },
            {
                id: 6,
                name: "These aren't the directives you're looking for",
                title: "John Papa",
                years: 2,
                level: "Junior",
                bio: `Coinciding with the release of Star Wars Episode 18, this talk will show how
          to use directives in your Angular 4 development while drawing lessons from the new movie,
          featuring all your favorite characters like Han Solo's ghost and Darth Jar Jar.`,
                voters: ['bradblack', 'martinfowler']
            }
        ]
    },
    {
        id: 4,
        description: 'Yahoo! is a web services provider, wholly owned by Verizon Communications through Oath Inc. and headquartered in Sunnyvale, California.',
        createdDate: '3/2/1995',
        createdTime: '10:00 am',
        membershipFee: 2.99,
        imageUrl: "/app/assets/images/yahoo-logo.png",
        onlineUrl: "http://google.com",
        //ownerAddress: {
        //    address: '62 Mozart ave',
        //    city: 'salt Lake city',
        //    country: 'US'
        //},
        authors: [
            {
                id: 1,
                name: "Nancy Smith",
                title: "Developer",
                years: 2,
                level: "Beginner",
                bio: `Bio`,
                voters: ['bradblack', 'igorminar']
            },
            {
                id: 2,
                name: "Zach Galifi",
                title: "Writer",
                years: 2,
                level: "Beginner",
                bio: `Zach's bio`,
                voters: ['bradblack', 'igorminar', 'johnpapadapolis']
            },
            {
                id: 3,
                name: "Dan Hurry",
                title: "Manager",
                years: 3,
                level: "Advanced",
                bio: `Dan likes andriods`,
                voters: ['igorminar', 'johnpapadapolis']
            }
        ]
    },
    {
        id: 5,
        description: 'Nfl.com is popular this time of year ',
        createdDate: '9/26/2013',
        createdTime: '8:00 am',
        membershipFee: 222.99,
        imageUrl: "",
        ownerAddress: {
            address: 'The Excaliber',
            city: 'Las Vegas',
            country: 'US'
        },
        authors: [
            {
                id: 1,
                name: "John Papadapolis",
                title: "Developer",
                years: 2,
                level: "Beginner",
                bio: `Bio for John`,
                voters: ['bradblack', 'igorminar']
            },
            {
                id: 2,
                name: "Dan Hurry",
                title: "Manager",
                years: 3,
                level: "Advanced",
                bio: `Dan likes andriods`,
                voters: ['igorminar', 'johnpapadapolis']
            }
        ]
    }
]


