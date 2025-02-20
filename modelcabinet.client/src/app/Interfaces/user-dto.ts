export interface UserDto {
  id: string;
  email: string;
  displayName: string;
  biography?: string;
  location?: string;
  website?: string;
  avatarUrl?: string;
  twitterHandle?: string;
  githubUsername?: string;
  preferredLanguage?: string;
  timeZone?: string;
  dateJoined: Date;
  lastActive: Date;
  isProfilePublic: boolean;
  emailNotificationsEnabled: boolean;
  projectUpdatesEnabled: boolean;
  newMessageNotificationsEnabled: boolean;
}
