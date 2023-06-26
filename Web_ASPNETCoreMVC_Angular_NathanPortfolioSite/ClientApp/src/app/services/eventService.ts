export class EventService {
  static events: Record<string, (() => void)[]> = {};

  static publishEvent(eventName: string) {
    if (Object.keys(this.events).includes(eventName))
      this.events[eventName].map((cb) => cb());
  }

  static listenEvent(eventName: string, callback: () => void) {
    if (!Object.keys(this.events).includes(eventName))
      this.events[eventName] = [callback];
    else {
      this.events[eventName] = [...this.events[eventName], callback];
    }
  }
}
