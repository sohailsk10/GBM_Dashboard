import argparse

parser = argparse.ArgumentParser()
parser.add_argument("--ip", dest="ip", default="0.0.0.0", help="Enter IP ADDRESS")
parser.add_argument("--user", dest="user", default="root", help="Enter USERNAME")
parser.add_argument("--password", dest="password", default="admin", help="Enter PASSWORD")
parser.add_argument("--port", dest="port", default="8000", help="Enter PORT NUMBER")

args = parser.parse_args()
print(args.ip)
print(args.user)
print(args.password)
print(args.port)