import win32pipe
import win32file

pipe_name = r'\\.\pipe\OceanMotion'

def named_pipe_client():
    pipe = win32file.CreateFile(
        pipe_name,
        win32file.GENERIC_READ | win32file.GENERIC_WRITE,
        0,
        None,
        win32file.OPEN_EXISTING,
        0,
        None
    )

    print("Connected to server.")
    try:
        while True:
            message = input("Enter message to send (type 'exit' to quit): ")
            if message.lower() == "exit":
                break
            message += '\n'  # Add a newline character at the end of the message
            win32file.WriteFile(pipe, message.encode())
            response = win32file.ReadFile(pipe, 4096)[1].decode()
            print("Received from server:", response)
    finally:
        win32file.CloseHandle(pipe)

if __name__ == "__main__":
    named_pipe_client()
