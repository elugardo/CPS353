export interface IWebsite {
    id: number,
    description: string,
    createdDate: Date,
    createdTime: string,
    membershipFee: number,
    imageUrl: string,
    ownerAddress?: {
        address: string,
        city: string,
        country: string
    },
    onlineUrl?:string,
    authors: IAuthor[]
}
export interface IAuthor {
    id: number,
    name: string,
    title: string,
    years: number,
    level: string,
    bio: string,
    voters: string[]

}
